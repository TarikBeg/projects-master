import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { AppConfig } from 'src/app/app-config';
import { ApiErrorResponse, ApiResponse } from 'src/app/shared/models/shared.models';

import { Movie } from '../movie';

@Injectable()
export class MoviesApiService {
    constructor(readonly http: HttpClient, readonly appConfig: AppConfig) {
    }

    searchMovies(keyword: string, page: number, pageSize: number): Observable<ApiResponse<Movie[]>> {
        return this.http.get<ApiResponse<Movie[]>>(`${this.baseUrl}?keyword=${keyword}&page=${page}&pageSize=${pageSize}`);
    }

    addStars(movieId: string, stars: number): Observable<ApiResponse<void> | ApiErrorResponse> {
        return this.http.post<ApiResponse<void> | ApiErrorResponse>(`${this.baseUrl}/movie?tenantid=${movieId}`, { stars: stars });
    }

    get baseUrl(): string {
        return `${this.appConfig.appSettings.apiEndpoints.endpoint}/movie`;
    }
}
