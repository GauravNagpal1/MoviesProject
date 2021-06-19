import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { ActivatedRoute, Router } from '@angular/router';

import { Movie } from '../movies-list/movie-list.component';

@Component({
  selector: 'app-movie-details',
  templateUrl: './movie-details.component.html'
})
export class FetchMovieDetailsComponent {
  public movie: Movie;

  constructor(private http: HttpClient, private route: ActivatedRoute, @Inject('BASE_URL') baseUrl: string) {

    var id = this.route.snapshot.params["id"];

    http.get<Movie[]>(baseUrl + 'api/movies/details/'+ id).subscribe(result => {
      this.movie = result;
      console.log("Hello", result)

    }, error => console.error(error));
  }
}