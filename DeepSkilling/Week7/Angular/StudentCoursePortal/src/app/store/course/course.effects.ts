import { Injectable, inject } from '@angular/core';

import { Actions, createEffect, ofType } from '@ngrx/effects';

import { map } from 'rxjs/operators';

import { CourseService } from '../../services/course';

import * as CourseActions from './course.actions';

@Injectable()
export class CourseEffects {

  private actions$ = inject(Actions);

  private courseService = inject(CourseService);

  loadCourses$ = createEffect(() =>
    this.actions$.pipe(

      ofType(CourseActions.loadCourses),

      map(() => {

        const courses = this.courseService.getCourses();

        return CourseActions.loadCoursesSuccess({
          courses
        });

      })

    )
  );

}