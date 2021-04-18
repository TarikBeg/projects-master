import { CommonModule } from '@angular/common';
import { NgModule } from '@angular/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';

import { SharedModule } from '../shared/shared.module';
import { MovieListComponent as MovieListComponent } from './movie-list/movie-list.component';
import { MovieRoutingModule as MoviesRoutingModule } from './movies-routing.module';
import { RateMovieComponent } from './rate-movie/rate-movie.component';
import { MoviesApiService } from './services/movies-api.service';

@NgModule({
    declarations: [
        MovieListComponent,
        RateMovieComponent
    ],
    imports: [MoviesRoutingModule, SharedModule, FormsModule, ReactiveFormsModule, CommonModule],
    providers: [MoviesApiService]
})
export class MoviesModule { }
