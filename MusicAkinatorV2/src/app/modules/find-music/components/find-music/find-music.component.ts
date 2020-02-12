import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'ma-find-music',
  templateUrl: './find-music.component.html',
  styleUrls: ['./find-music.component.css']
})
export class FindMusicComponent implements OnInit {

  songLyric: string;
  constructor() { }

  ngOnInit() {
  }

}
