import { Injectable } from '@angular/core';

@Injectable({ providedIn: "root" })
export class AppConfig {
    appSettings!: {
        apiEndpoints: {
            endpoint: string;
            version: string;
        };
        idp: {
            clientId: string;
            clientSecret: string;
            scope: string;
            endpoint: string;
        };
        hostname: string;
    };
}
