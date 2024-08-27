import { Component, Input, Output, EventEmitter } from '@angular/core';
import { FormsModule } from '@angular/forms'; // For ngModel
import { CommonModule } from '@angular/common'; // For basic directives
import { AuthService } from '../../Services/auth.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-two-factor-auth',
  standalone: true,
  imports: [FormsModule, CommonModule],
  templateUrl: './two-factor-auth.component.html',
  styleUrls: ['./two-factor-auth.component.css']
})
export class TwoFactorAuthComponent {
  @Input() userId: number | null = null;
  twoFactorCode: string = '';
  
  @Output() verified = new EventEmitter<void>();
  
  constructor(private authService: AuthService, private router: Router) {}

  onVerify2FA() {
    if (this.userId && this.twoFactorCode) {
      this.authService.verify2FA({ userId: this.userId, twoFactorCode: this.twoFactorCode }).subscribe(
        (response: any) => {
          // Store the JWT token
          localStorage.setItem('authToken', response.token);
          alert('Login successful!');
          this.verified.emit(); // obavjestava login o uspjesnoj prijavi
          this.router.navigate(['#']); 
        },
        (error) => {
          alert('Invalid or expired 2FA code!');
        }
      );
    } else {
      alert('Please enter the 2FA code.');
    }
  }
}
