import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class TokenService {
  
  constructor() {}

  // Decode the JWT Token
  decodeToken(token: string): any {
    if (!token) {
      return null;
    }
    
    // Split the token by dots and decode the payload (the second part)
    const payload = token.split('.')[1];
    
    // Decode from Base64
    const decodedPayload = atob(payload);
    
    // Parse JSON
    return JSON.parse(decodedPayload);
  }

  // Check if the token is expired
  isTokenExpired(token: string): boolean {
    const decodedToken = this.decodeToken(token);

    if (!decodedToken || !decodedToken.exp) {
      return true; // If there's no expiration field, treat the token as expired
    }

    const expirationDate = new Date(0);
    expirationDate.setUTCSeconds(decodedToken.exp);

    return expirationDate < new Date(); // Compare the expiration time with the current time
  }

  // Get the expiration date from the token
  getTokenExpirationDate(token: string): Date | null {
    const decodedToken = this.decodeToken(token);

    if (!decodedToken || !decodedToken.exp) {
      return null;
    }

    const expirationDate = new Date(0);
    expirationDate.setUTCSeconds(decodedToken.exp);
    return expirationDate;
  }
}
