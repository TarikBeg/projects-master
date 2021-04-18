import { HttpClientModule, HttpErrorResponse } from '@angular/common/http';
import { APP_INITIALIZER, Injector, NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { BrowserModule } from '@angular/platform-browser';
import { Router } from '@angular/router';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { ConfigService } from './core/config/config.service';
import { CoreModule } from './core/core.module';
import { SharedModule } from './shared/shared.module';

export function configAndLogsServiceFactory(
  config: ConfigService,
  injector: Injector,

) {
  return () =>
    config.load()
      .catch((error: HttpErrorResponse) => {
        const router = injector.get(Router);
        if (error.status === 404) router.navigate(["/errors/404"]);
      })
}

@NgModule({
  declarations: [
    AppComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    SharedModule,
    CoreModule
  ],
  providers: [
    ConfigService,
    {
      provide: APP_INITIALIZER,
      useFactory: configAndLogsServiceFactory,
      deps: [
        ConfigService,
      ],
      multi: true
    }
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
