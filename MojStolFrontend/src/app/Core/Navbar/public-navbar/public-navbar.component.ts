import { Component, OnInit, Inject, PLATFORM_ID } from '@angular/core';
import { CommonModule, isPlatformBrowser } from '@angular/common';
import { Router, RouterModule } from '@angular/router';
import { TokenService } from '../../../Services/token.service';

@Component({
  selector: 'app-public-navbar',
  standalone: true,
  imports: [CommonModule, RouterModule],
  templateUrl: './public-navbar.component.html',
  styleUrls: ['./public-navbar.component.css']
})
export class PublicNavbarComponent implements OnInit {
  isLoggedIn: boolean = false;
  userName: string = '';

  constructor(
    @Inject(PLATFORM_ID) private platformId: Object, // Inject PLATFORM_ID
    private router: Router,
    private tokenService: TokenService
  ) {}

  ngOnInit(): void {
    // Check if running in the browser
    if (isPlatformBrowser(this.platformId)) {
      const token = localStorage.getItem('authToken');

      if (token && !this.tokenService.isTokenExpired(token)) {
        this.isLoggedIn = true;
        const decodedToken = this.tokenService.decodeToken(token);

        this.userName = decodedToken.Name || 'User';
      } else {
        this.isLoggedIn = false;
      }
    }
  }

  logout(): void {
    if (isPlatformBrowser(this.platformId)) {
      localStorage.removeItem('authToken');
      this.isLoggedIn = false;
    }
    this.router.navigate(['/']);
  }
}
