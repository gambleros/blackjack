
module.exports={
	entry: './js/main.js',
	output:{
		filename: 'bundle.js'
	},
	module:{
		loaders: [
			{test: /\.jsx?$/ ,exclude: /node_modules/, loader:'babel'}
		]
	},
	resolve:{
		extensions: ['','.js','.jsx']
	}
};