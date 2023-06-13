import { config } from './app/app.config.server';
import {bootstrapApplication} from '@angular/platform-browser';
import { AppComponent } from './app/app.component';

const bootstrap = () => bootstrapApplication(AppComponent, config);

export default bootstrap;

export { AppServerModule } from './app/app.server.module';