import { NgModule } from '@angular/core';
import { AppModule } from './app.module';
import { AppComponent } from './app.component';
import '@angular/platform-server/init';
import { enableProdMode } from '@angular/core';


@NgModule({
  imports: [
    AppModule,
    AppServerModule,
  ],
  bootstrap: [AppComponent],
})
export class AppServerModule {}
