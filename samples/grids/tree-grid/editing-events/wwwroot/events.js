

igRegisterScript("WebTreeGridCellEdit", (event) => {
	const column = event.detail.column;
	if (column.field === 'Age') {
		if (event.detail.newValue < 18) {
			event.detail.cancel = true;
			alert('Employees must be at least 18 years old!');
		}
	} else if (column.field === 'HireDate') {
		if (event.detail.newValue > new Date().getTime()) {
			event.detail.cancel = true;
			alert('The employee hire date must be in the past!');
		}
	}
}, false);

