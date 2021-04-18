import { Component, Input, OnInit } from '@angular/core';

@Component({
  selector: 'star-rating',
  templateUrl: './star-rating.component.html'
})
export class StarRatingComponent implements OnInit {
  @Input() rating: number = 0;
  numbers: any[] = [];

  ngOnInit(): void {
    const number = Math.floor(this.rating);
    if (number > 0) {
      this.numbers = Array(number).fill(number - 1);
    }
  }
}
