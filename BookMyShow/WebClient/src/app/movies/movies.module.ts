import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { MoviesRoutingModule } from './movies-routing.module';
import { MoviesComponent } from './movies/movies.component';
import { MovieDetailsComponent } from './movie-details/movie-details.component';
import { SeatSelectionComponent } from './seat-selection/seat-selection.component';
import { TheatresComponent } from './theatres/theatres.component';
import { DateFilterComponent } from './movies/date-filter/date-filter.component';
import { LanguageFilterComponent } from './movies/language-filter/language-filter.component';
import { StatusFilterComponent } from './movies/status-filter/status-filter.component';
import { MovieCardComponent } from './movies/movie-card/movie-card.component';


@NgModule({
  declarations: [
    MoviesComponent,
    MovieDetailsComponent,
    SeatSelectionComponent,
    TheatresComponent,
    DateFilterComponent,
    LanguageFilterComponent,
    StatusFilterComponent,
    MovieCardComponent
  ],
  imports: [
    CommonModule,
    MoviesRoutingModule
  ],
  exports:[
    MoviesComponent
  ]
})

export class MoviesModule { }
