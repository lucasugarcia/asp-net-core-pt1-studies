class Carrinho {
    clickIncremento(btn) {
        let data = this.getData(btn);

        data.Quantidade++;

        this.postQuantidade(data, btn);
    }

    clickDecremento(btn) {
        let data = this.getData(btn);

        data.Quantidade--;

        this.postQuantidade(data, btn);
    }

    getData(elemento) {
        var linhaDoItem = $(elemento).parents('[item-id]');
        var itemId = $(linhaDoItem).attr('item-id');
        var novaQuantidade = $(linhaDoItem).find('input').val();

        return {
            Id: itemId,
            Quantidade: novaQuantidade
        };
    }

    postQuantidade(data, elemento) {
        this.updateValorInput(data.Quantidade, elemento);

        $.ajax({
            url: '/pedido/updatequantidade',
            type: 'POST',
            contentType: 'application/json',
            data: JSON.stringify(data)
        });
    }

    updateQuantidade(input) {
        let data = this.getData(input);

        this.postQuantidade(data, input);
    }

    updateValorInput(quantidade, elemento) {
        var linhaDoItem = $(elemento).parents('[item-id]');
        $(linhaDoItem).find('input').val(quantidade);
    }
}

var carrinho = new Carrinho();