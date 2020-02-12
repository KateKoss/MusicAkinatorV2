import { NgModule }      from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { FormsModule }   from '@angular/forms';
import { AppComponent }   from './components/app/app.component';
import { FindMusicModule } from '../find-music/find-music.module'
import { FindMusicComponent } from '../find-music/components/find-music/find-music.component';
@NgModule({
   imports: [
      BrowserModule,
      FormsModule,
      FindMusicModule
   ],
   declarations: [
      AppComponent,
      FindMusicComponent
   ],
   bootstrap: [
      AppComponent
   ]
})
export class AppModule { }