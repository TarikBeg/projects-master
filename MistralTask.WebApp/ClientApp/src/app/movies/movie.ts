import { Actor } from './actor';

export interface Movie {
    title: string;
    releaseDate: Date;
    coverImage: string
    description: string;
    rating: number;
    actors: Actor[];
}
