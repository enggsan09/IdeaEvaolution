import { Component, OnInit } from '@angular/core';
import { Judge, Idea} from '../shared/model';

@Component({
  selector: 'app-judge',
  templateUrl: './judge.component.html',
  styleUrls: ['./judge.component.css']
})
export class JudgeComponent implements OnInit {

  viewModel: Judge;
  
  constructor() { }

  ngOnInit(): void {
  }

}
