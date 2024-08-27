import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';
import { PublicNavbarComponent } from '../../Core/Navbar/public-navbar/public-navbar.component';
import { FooterComponent } from '../../Core/Footer/footer/footer.component';

@Component({
  selector: 'app-landing',
  standalone: true,
  imports: [CommonModule, PublicNavbarComponent, FooterComponent],
  templateUrl: './landing.component.html',
  styleUrl: './landing.component.css'
})
export class LandingComponent {

}
