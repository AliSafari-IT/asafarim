import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { environment } from '../../../environments/environment';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class ApiService {
  private baseUrl = `${environment.apiBaseUrl}/api/portfolios`;

  constructor(private http: HttpClient) {}

  private getHeaders(): HttpHeaders {
    const token = localStorage.getItem('auth') ? JSON.parse(localStorage.getItem('auth')!).token : null;
    return new HttpHeaders({
      'Content-Type': 'application/json',
      Authorization: token ? `Bearer ${token}` : ''
    });
  }

  getAllPortfolios(): Observable<any[]> {
    return this.http.get<any[]>(`${this.baseUrl}`, {
      headers: this.getHeaders()
    });
  }

  getPortfolioByUserId(userId: string): Observable<any> {
    return this.http.get<any>(`${this.baseUrl}/user/${userId}`, {
      headers: this.getHeaders()
    });
  }

  createPortfolio(portfolioData: any): Observable<any> {
    return this.http.post<any>(`${this.baseUrl}/create`, portfolioData, {
      headers: this.getHeaders()
    });
  }

  updatePortfolio(userId: string, portfolioData: any): Observable<any> {
    return this.http.put<any>(`${this.baseUrl}/update/${userId}`, portfolioData, {
      headers: this.getHeaders()
    });
  }

  deletePortfolio(userId: string): Observable<any> {
    return this.http.delete<any>(`${this.baseUrl}/delete/${userId}`, {
      headers: this.getHeaders()
    });
  }
}
