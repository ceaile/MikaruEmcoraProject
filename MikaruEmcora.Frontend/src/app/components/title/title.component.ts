import { Component, Input, Output, EventEmitter, OnChanges, SimpleChanges } from '@angular/core';

@Component({
  selector: 'app-title',
  templateUrl: './title.component.html',
  styleUrl: './title.component.css'
})
export class TitleComponent implements OnChanges {
  @Input() varTitle = '';
  @Output() dataFromChild = new EventEmitter();

  ngOnChanges(changes: SimpleChanges): void {

    console.log(changes);
    this.dataFromChild.emit('data from child component');
  }
  
}
