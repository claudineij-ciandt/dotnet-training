<template>
    <div>
        <div class="row">
            <div class="col-sm-8">
                <h1>Produtos</h1>
            </div>
            <div class="col-sm-4">
                <div class="search-box" style="margin-top: 10px">
                    <input type="text" class="form-control" placeholder="Descrição" v-on:blur="onBlurSearch">
                </div>
            </div>
        </div>

        <div class="row">
            <div class="col-sm-10">
            </div>
            <div class="col-sm-2" style="text-align: right; margin: 15px 0px;">
                <router-link :to="{name: 'CreateProduto' }" class="btn btn-outline-secondary">Add Produto</router-link>
            </div>
        </div>

        <table class="table table-hover">
            <thead>
            <tr>
                <td>Id</td>
                <td>Código</td>
                <td>Descrição</td>
                <td>Categoria</td>
                <td>Preço</td>
                <td>Un. Medida</td>
                <td colspan="2">Actions</td>
            </tr>
            </thead>

            <tbody>
                <tr v-for="item in items" :key="item.id">
                    <td>{{ item.id }}</td>
                    <td>{{ item.codigo }}</td>
                    <td>{{ item.descricao }}</td>
                    <td>{{ item.categoria.descricao }}</td>
                    <td>{{ item.preco }}</td>
                    <td>{{ item.unidadeMedida }}</td>
                    <td><router-link :to="{name: 'EditProduto', params: { id: item.id }}" class="btn btn-outline-primary">Edit</router-link></td>
                    <td><button class="btn btn-outline-danger"  v-on:click="deleteItem(item.id)">Delete</button></td>
                </tr>
            </tbody>
        </table>
    </div>
</template>

<script>

    export default {
        data(){
            return{
                items: [],
                filtro: ''
            }
        },

        created: function()
        {
            this.fetchItems();
        },

        methods: {
            fetchItems()
            {
              let uri = 'http://localhost:5000/api/produtos';
              this.axios.get(uri).then((response) => {
                  this.items = response.data;
              });
            },
            deleteItem(id)
            {
              let uri = 'http://localhost:5000/api/produtos/' + id;

              this.axios.delete(uri).then(() => {
                  this.items.splice(id, 1);
              });
            },
            onBlurSearch (event) {
                let uri = 'http://localhost:5000/api/produtos/search?descricao=' + event.srcElement.value;
                this.axios.get(uri).then((response) => {
                    this.items = response.data;
                });
            }
        }
    }
</script>
