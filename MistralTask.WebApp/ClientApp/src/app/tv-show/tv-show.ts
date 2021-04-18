import { Actor } from './actor';

export interface TvShow {
  id: string;
  title: string;
  releaseDate: Date;
  coverImage: string
  description: string;
  rating: number;
  actors: Actor[];
  addedStars: number;
}
