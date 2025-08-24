import { Component, signal } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { Postcomponent } from './postcomponent/postcomponent';

@Component({
  selector: 'app-root',
  imports: [Postcomponent],
  template : `<app-posts></app-posts>`,
  styleUrl: './app.css'
})
export class App {
  protected readonly title = signal('fetchdataapi_demo');
}
