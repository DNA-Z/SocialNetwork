<script>
	let count = 0;

	function incrementCount() {
		count += 1;
	}

    $: {
		console.log('значение count равно ' + count);
	    alert('Я СКАЗАЛ ЗНАЧЕНИЕ count РАВНО ' + count);
	
	    if (count >= 10) {
		    alert('значение count слишком велико!');
		    count = 9;
	    }
	}


</script>

<button on:click={incrementCount}>
	{count === 0 ? 'Кликни по мне' : `Кликов: ${count}`}
</button>