import { Component, OnInit } from "@angular/core"
import  GameRulesModel from "@models/GameRulesModel"

@Component({
  selector: 'ma-game-rules',
  templateUrl: './game-rules.component.html',
  styleUrls: ['./game-rules.component.css']
})
export class GameRulesComponent implements OnInit{
  currentGame: GameRulesModel;
  constructor() {}
  ngOnInit() {}
}