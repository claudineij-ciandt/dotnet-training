<template>
  <div id="app" class="container">
    <nav class="navbar navbar-expand-sm bg-light">
      <ul class="navbar-nav">
        <li class="nav-item">
          <router-link :to="{ name: 'IndexProduto' }" class="nav-link">Produtos</router-link>
        </li>
        <li class="nav-item">
          <router-link :to="{ name: 'IndexCategoria' }" class="nav-link">Categorias</router-link>
        </li>
      </ul>
    </nav>
    <transition name="fade">
      <div class="gap">
        <router-view></router-view>        
      </div>
    </transition>
  </div>
</template>

<style>
.fade-enter-active, .fade-leave-active {
    transition: opacity .5s
  }
  .fade-enter, .fade-leave-active {
    opacity: 0
  }
  .gap {
    margin-top: 50px;
  }
</style>
