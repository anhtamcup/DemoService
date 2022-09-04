const uri = 'api/Image';
let todos = [];

function getItems() {
	fetch(uri)
		.then(response => response.json())
		.then(data => _displayItems(data))
		.catch(error => console.error('Unable to get items.', error));
}

function _displayItems(data) {
	const tBody = document.getElementById('images');
	tBody.innerHTML = '';
	data.forEach(item => {

		//console.log(item);
		let tr = tBody.insertRow();
		let td1 = tr.insertCell(0);
		td1.appendChild(document.createTextNode(item.id));

		let td2 = tr.insertCell(1);
		let textNode = document.createTextNode(item.path);
		td2.appendChild(textNode);
	});
}

function addItem() {
	fetch('api/Image/GetModel', {
		method: 'POST',
		headers: {
			'Accept': 'application/json',
			'Content-Type': 'application/json'
		},
		body: JSON.stringify({ 'Id': '1', 'Path': 'xxx.com' })
	})
		.then(response => response.json())
		.then(item => console.log(item));
};