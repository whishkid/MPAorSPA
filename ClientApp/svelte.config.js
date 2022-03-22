import adapter from '@sveltejs/adapter-static';

/** @type {import('@sveltejs/kit').Config} */
const config = {
	kit: {
		adapter: adapter({
			pages: '../serverapp/serverapp/wwwroot/kit',
			assets: '../serverapp/serverapp/wwwroot/kit',
			fallback: 'sveltekit.html',
		})
	}
};

export default config;
