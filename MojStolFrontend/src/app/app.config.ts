import { provideRouter, Routes } from '@angular/router';
import { provideHttpClient, withFetch} from '@angular/common/http';
import { LandingComponent } from './Public/landing/landing.component';
import { LoginComponent } from './Auth/login/login.component';
import { RegisterComponent } from './Auth/register/register.component';
import { ResetPasswordComponent } from './Auth/reset-password/reset-password.component';



const routes: Routes = [
  { path: '', component: LandingComponent },
  { path: 'login', component: LoginComponent },
  { path: 'register', component: RegisterComponent }, 
  { path: 'reset-password', component: ResetPasswordComponent },


];

export const appConfig = {
  providers: [
    provideRouter(routes),
    provideHttpClient(withFetch())  // Provide HttpClient globally
  ]
};
