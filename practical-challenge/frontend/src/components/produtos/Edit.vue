<template>
  <div class="container">
        <div v-if="error" class="alert alert-danger" role="alert">
            <ul>
                 <li>{{ error }}</li>
            </ul>
        </div>

        <div class="card">
            <div class="card-header">
                <h3>Edit Item</h3>
            </div>
            <div class="card-body">
                <form v-on:submit.prevent="updateItem">
                    <div class="form-group">
                        <label>Código:</label>
                        <input type="text" class="form-control" v-model="item.codigo"/>
                    </div>
                    <div class="form-group">
                        <label>Descrição:</label>
                        <input type="text" class="form-control" v-model="item.descricao"/>
                    </div>
                    <div class="form-group">
                        <label>Categoria:</label>
                        <select v-model="item.categoria" class="form-control">
                            <option v-for="categoria in categorias" :value="categoria" :key="categoria.id">
                                {{ categoria.descricao }}
                            </option>
                        </select>
                    </div>
                    <div class="form-group">
                        <label>Preço:</label>
                        <input type="text" class="form-control" v-model="item.preco"/>
                    </div>
                    <div class="form-group">
                        <label>Un. de Medida:</label>
                        <input type="text" class="form-control" v-model="item.unidadeMedida"/>
                    </div>
                    <div class="form-group">
                        <input type="submit" class="btn btn-primary" value="Edit Item"/>
                    </div>
                </form>
            </div>
        </div>
    </div>
</template>
<script>
export default{
        data(){
            return{
                item:{
                    categoria: {}
                },
                categorias: [],
                error: null
            }
        },

        created: function(){
            this.getCategorias();
        },

        methods: {
            getItem()
            {
                this.error = null;
                let uri = 'http://localhost:5000/api/produtos/' + this.$route.params.id;
                this.axios.get(uri).then((response) => {
                    this.item = response.data;
                    for (let index = 0; index < this.categorias.length; index++) {
                        if(this.item.categoria.id == this.categorias[index].id) {
                            this.item.categoria = this.categorias[index];
                        }
                    }
                });
            },

            getCategorias()
            {
                let uri = 'http://localhost:5000/api/categorias/';

                this.axios.get(uri).then((response) => {
                    this.categorias = response.data;
                    this.getItem();
                });
            },

            updateItem()
            {
              let uri = 'http://localhost:5000/api/produtos/' + this.$route.params.id;
                this.axios.put(uri, this.item).then(() => {
                  this.$router.push({name: 'IndexProduto'});
                }).catch((error) => {
                    this.error = error.response.data;
                });
            }
        }
    }
</script>
