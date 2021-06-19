import { Component, Inject, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-movie-data',
  templateUrl: './movie-list.component.html'
})
export class FetchMoviesComponent implements OnInit {
  public movies: Movie[];
  private isSortingAscending = true;

  public text= "ASC";

  constructor(private http: HttpClient, @Inject('BASE_URL') private baseUrl: string) {    
  }

  ngOnInit(): void {
    this.http.get<Movie[]>(this.baseUrl + 'api/movies/all').subscribe(result => {
      this.movies = result;
    }, error => console.error(error));
  }

  toggleSort = function () {
    this.isSortingAscending = !this.isSortingAscending;
    
    if (this.isSortingAscending) {
      this.movies = this.movies.sort((x,y)=>x.title-y.title);
      this.text = "ASC";
    } else {
      this.movies = this.movies.sort((x,y)=>y.title-x.title);
      this.text = "DESC";
    }
  }
  
}

export interface Movie {
  id: string

  language: string

  location: string

  plot: string

  poster: string

  soundEffects: string[]

  stills: string[]

  title: string

  imdb_id: string

  listingType: string

  imdbRating: string
}