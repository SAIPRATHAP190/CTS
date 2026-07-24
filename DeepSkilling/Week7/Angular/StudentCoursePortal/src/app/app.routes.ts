import { Routes } from '@angular/router';

import { Home } from './components/home/home';
import { StudentProfile } from './components/student-profile/student-profile';
import { CourseDetail } from './components/course-detail/course-detail';
import { NotFound } from './components/not-found/not-found';
import { CoursesLayout } from './components/courses-layout/courses-layout';
import { CourseList } from './components/course-list/course-list';

export const routes: Routes = [

  {
    path: '',
    component: Home
  },

  {
    path: 'profile',
    component: StudentProfile
  },

  {
    path: 'courses',
    component: CoursesLayout,
    children: [
      {
        path: '',
        component: CourseList
      },
      {
        path: ':id',
        component: CourseDetail
      }
    ]
  },

  {
    path: '**',
    component: NotFound
  }

];