<script>
    export let first_name;
    export let last_name;
    
    $: name = first_name + " " + last_name;  //Вычисляемое свойство
</script>

<h2>Hello, {name}!</h2>

<style>
    h2 {
        color: purple;
        font-family: 'Comic Sans MS';
        font-size: 2em;
    }
</style>