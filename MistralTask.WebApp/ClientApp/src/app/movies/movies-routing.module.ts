import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

import { MovieListComponent } from './movie-list/movie-list.component';
import { RateMovieComponent } from './rate-movie/rate-movie.component';


const routes: Routes = [
    {
        path: '',
        children: [
            {
                path: "",
                redirectTo: "list",
                pathMatch: "full",
            },
            {
                path: "list",
                component: MovieListComponent,
                data: {
                    showTopTitleBar: true,
                }
            },
            {
                path: "rate",
                component: RateMovieComponent,
                data: {
                    showTopTitleBar: true,
                }
            }
        ]
    }
];

@NgModule({
    imports: [RouterModule.forChild(routes)],
    exports: [RouterModule]
})
export class MovieRoutingModule { }
