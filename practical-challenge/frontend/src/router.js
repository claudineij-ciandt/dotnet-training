import Vue from 'vue'
import Router from 'vue-router'
import Create from './components/Create.vue';
import Edit from './components/Edit.vue';
import Index from './components/Index.vue';

Vue.use(Router)

export default new Router({
  routes: [
    {
      name: 'Create',
      path: '/create',
      component: Create
    },
    {
      name: 'Edit',
      path: '/edit/:id',
      component: Edit
    },
    {
      name: 'Index',
      path: '/',
      component: Index
    },
  ]
})