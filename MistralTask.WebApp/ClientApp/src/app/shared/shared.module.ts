import { CommonModule } from '@angular/common';
import { NgModule } from '@angular/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { RouterModule } from '@angular/router';

import { NavComponent } from './nav/nav.component';
import { StarRatingComponent } from './star-rating/star-rating.component';

@NgModule({
  imports: [
    CommonModule,
    RouterModule,
    FormsModule,
    ReactiveFormsModule
  ],
  declarations: [StarRatingComponent, NavComponent],
  exports: [StarRatingComponent, NavComponent]
})
export class SharedModule { }
