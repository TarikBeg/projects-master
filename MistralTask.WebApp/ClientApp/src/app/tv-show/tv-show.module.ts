import { CommonModule } from '@angular/common';
import { NgModule } from '@angular/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';

import { SharedModule } from '../shared/shared.module';
import { TwShowApiService } from './services/tv-show-api.service';
import { TwShowListComponent } from './tv-show-list/tv-show-list.component';
import { TvShowRoutingModule } from './tw-show-routing.module';

@NgModule({
    declarations: [
        TwShowListComponent,
    ],
    imports: [TvShowRoutingModule, SharedModule, FormsModule, ReactiveFormsModule, CommonModule],
    providers: [TwShowApiService]
})
export class TwShowModule { }
