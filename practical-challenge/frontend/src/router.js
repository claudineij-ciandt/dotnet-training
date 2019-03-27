import Vue from 'vue'
import Router from 'vue-router'
import Create from './components/produtos/Create.vue';
import Edit from './components/produtos/Edit.vue';
import Index from './components/produtos/Index.vue';

import CategoriaCreate from './components/categorias/Create.vue';
import CategoriaEdit from './components/categorias/Edit.vue';
import CategoriaIndex from './components/categorias/Index.vue';

Vue.use(Router)

export default new Router({
  routes: [
    {
      name: 'CreateProduto',
      path: '/produtos/create',
      component: Create
    },
    {
      name: 'EditProduto',
      path: '/produtos/edit/:id',
      component: Edit
    },
    {
      name: 'IndexProduto',
      path: '/',
      component: Index
    },
    {
      name: 'CreateCategoria',
      path: '/categorias/create',
      component: CategoriaCreate
    },
    {
      name: 'EditCategoria',
      path: '/categorias/edit/:id',
      component: CategoriaEdit
    },
    {
      name: 'IndexCategoria',
      path: '/categorias',
      component: CategoriaIndex
    }
  ]
})