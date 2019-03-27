<template>
  <div class="container">
        <div v-if="error" class="alert alert-danger" role="alert">
            <ul>
                 <li>{{ error }}</li>
            </ul>
        </div>
        <div class="card">
            <div class="card-header">
                <h3>Add Categoria</h3>
            </div>
            <div class="card-body">
                <form v-on:submit.prevent="addItem">
                    <div class="form-group">
                        <label>Código:</label>
                        <input type="text" class="form-control" v-model="item.codigo"/>
                    </div>
                    <div class="form-group">
                        <label>Descrição:</label>
                        <input type="text" class="form-control" v-model="item.descricao"/>
                    </div>
                    <div class="form-group">
                        <input type="submit" class="btn btn-primary" value="Criar"/>
                    </div>
                </form>
            </div>
        </div>
    </div>
</template>

<script>
export default {
  data() {
      return {
          item: { },
          error: null
      }
  },
  methods: {
        addItem() {
            let uri = 'http://localhost:5000/api/categorias';

            this.axios.post(uri, this.item, { headers: { 'Content-type': 'application/json' } })
            .then(() => this.$router.push('/categorias'))
            .catch((error) => {
                this.error = error.response.data;
            });
        }
    }
}
</script>