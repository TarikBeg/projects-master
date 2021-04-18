import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { AppConfig } from 'src/app/app-config';
import { ApiResponse } from 'src/app/shared/models/shared.models';

import { TvShow } from '../tv-show';

@Injectable()
export class TwShowApiService {
    constructor(readonly http: HttpClient, readonly appConfig: AppConfig) {
    }

    searchTvShow(keyword: string, page: number, pageSize: number): Observable<ApiResponse<TvShow[]>> {
        return this.http.get<ApiResponse<TvShow[]>>(`${this.baseUrl}?keyword=${keyword}&page=${page}&pageSize=${pageSize}`);
    }

    get baseUrl(): string {
        return `${this.appConfig.appSettings.apiEndpoints.endpoint}/TvShow`;
    }
}
