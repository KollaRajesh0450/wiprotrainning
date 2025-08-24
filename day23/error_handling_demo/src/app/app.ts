import { CommonModule } from '@angular/common';
import { Component, signal } from '@angular/core';
@Component({
  selector: 'app-root',
  imports: [CommonModule],
  template: `
    <button (click)="doSomething()">Do Something</button>
    <div *ngIf="errorMessage" class="error-message">
      {{ errorMessage }}
    </div>
  `,
  styles: ['.error-message { color: red; }'],
})
export class App {
  protected readonly title = signal('error_handling_demo');

  errorMessage: string | null = null;

  doSomething() {
    try {
      // Simulating an error
      const data = JSON.parse('invalid json');
      console.log(data);
    } catch (error: any) {
      // Handle the error
      this.errorMessage = `An error occurred: ${error.message}`;
      console.error('Synchronous error:', error);
    }
  }
}
