<script>
	import Greeting from './Greeting.svelte';
	import LoginIn from './LogIn.svelte';
	import FrameworkList from './FrameworkList.svelte';
	import EventDemo from './EventDemo.svelte';
	import BindingDemo from './BindingDemo.svelte';
	import ButtonCount from './ButtonCount.svelte';
	import AddNumber from './AddNumber.svelte';
	import Cats from './Cats.svelte';
	import Thing from './Thing.svelte';

	export let name;

	let things = [
		{ id: 1, name: 'apple' },
		{ id: 2, name: 'banana' },
		{ id: 3, name: 'carrot' },
		{ id: 4, name: 'doughnut' },
		{ id: 5, name: 'egg' },
	];

	function handleClick() {
		things = things.slice(1);
	}
</script>

<main>
	<h1>Hello, {name}!</h1>
	<Greeting first_name="Yuri" last_name="Shporhun"/>
	<LoginIn/>
	<ButtonCount/>
	<AddNumber/>
	<FrameworkList/>
	<EventDemo/>
	<BindingDemo/>
	<Cats/>


	<button on:click={handleClick}> Удалить первый элемент </button>

{#each things as thing (thing.id)}
	<Thing name={thing.name} />
{/each}

	<p>Visit the <a href="https://svelte.dev/tutorial">Svelte tutorial</a> to learn how to build Svelte apps.</p>


</main>

<style>
	main {
		text-align: center;
		padding: 1em;
		max-width: 240px;
		margin: 0 auto;
	}

	h1 {
		color: #ff3e00;
		font-family: 'Comic Sans MS';
		font-size: 4em;
		font-weight: 100;
	}

	p{
		color: darkblue;
		font-family: 'Comic Sans MS';
	}

	@media (min-width: 640px) {
		main {
			max-width: none;
		}
	}
</style>