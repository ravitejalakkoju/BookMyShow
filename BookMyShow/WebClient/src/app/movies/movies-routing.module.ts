import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { MovieDetailsComponent } from './movie-details/movie-details.component';
import { MoviesComponent } from './movies/movies.component';
import { SeatSelectionComponent } from './seat-selection/seat-selection.component';
import { TheatresComponent } from './theatres/theatres.component';

const routes: Routes = [
  {path: '', component: MoviesComponent, pathMatch: 'full'},
  {path: ':movieId', component: MovieDetailsComponent},
  {path: ':movieId/theatres', component: TheatresComponent, children: [
    {path: ':theatreId', component: SeatSelectionComponent}
  ]}
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class MoviesRoutingModule { }
