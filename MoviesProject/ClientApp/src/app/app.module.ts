import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { RouterModule } from '@angular/router';

import { AppComponent } from './app.component';
import { NavMenuComponent } from './nav-menu/nav-menu.component';
import { HomeComponent } from './home/home.component';
import { FetchMoviesComponent } from './movies-list/movie-list.component';
import { FetchMovieDetailsComponent } from './movies-details/movie-details.component';

@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
    HomeComponent,
    FetchMoviesComponent,
    FetchMovieDetailsComponent
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    RouterModule.forRoot([
      { path: '', component: FetchMoviesComponent, pathMatch: 'full' },
      { path: 'home', component: HomeComponent },
      { path: 'movieslist/detail/:id', component: FetchMovieDetailsComponent},
      { path: 'movieslist', component: FetchMoviesComponent },
      { path: '**', redirectTo: "movieslist" },
    ])
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
