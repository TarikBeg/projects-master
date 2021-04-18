import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

import { TwShowListComponent } from './tv-show-list/tv-show-list.component';


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
                component: TwShowListComponent,
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
export class TvShowRoutingModule { }
