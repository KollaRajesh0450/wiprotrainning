import { Component, OnInit } from '@angular/core';
import { DataService } from '../data-service';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-posts',
  imports: [CommonModule],
  template: `
  <ul>
    <li *ngFor="let post of posts">
      {{ post.title }}
    </li>
  </ul>
  `,
})
export class Postcomponent implements OnInit{
  posts:any[]=[];
  constructor(private DataService: DataService){}
  ngOnInit(): void {
    this.DataService.getPosts().subscribe((data)=>{
      this.posts=data;
    });
  }
}