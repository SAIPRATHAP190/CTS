import {
  Component,
  Input,
  OnChanges,
  SimpleChanges
} from '@angular/core';
import { CommonModule } from '@angular/common';
import { CourseDurationPipe } from '../../pipes/course-duration-pipe';

@Component({
  selector: 'app-course-card',
  standalone: true,
  imports: [CommonModule, CourseDurationPipe],
  templateUrl: './course-card.html',
  styleUrl: './course-card.css'
})
export class CourseCard implements OnChanges {

  @Input()
  course: any;

  ngOnChanges(changes: SimpleChanges): void {
    console.log(
      'Course changed:',
      changes['course']?.previousValue,
      '=>',
      changes['course']?.currentValue
    );
  }

}