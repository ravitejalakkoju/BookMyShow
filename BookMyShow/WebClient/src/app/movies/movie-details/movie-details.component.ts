import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { MoviesService } from '../../services/movies.service';

import { IMovieDetails } from '../../Interfaces/IMovieDetails';
import { IMovie } from '../../Interfaces/IMovie';

@Component({
  selector: 'app-movie-details',
  templateUrl: './movie-details.component.html',
  styleUrls: ['./movie-details.component.sass']
})
export class MovieDetailsComponent implements OnInit {

  movieId: string;
  movieDetails: IMovieDetails;
  movie: IMovie;
  constructor(private route: ActivatedRoute, private movieService: MoviesService) { }

  ngOnInit(): void {
    this.movieId = this.route.snapshot.paramMap.get('movieId');
    this.movieService.getMovie(parseInt(this.movieId)).subscribe(result => {
      this.movie = result
      this.movieService.getMovieDetails(this.movie.apiid).subscribe(result => {
        this.movieDetails = result
      }, error => console.error(error))
    }, error => console.error(error))
  }

}
