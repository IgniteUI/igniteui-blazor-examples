
igRegisterScript("WebTreeGridRowStylesHandler", () => {
    return {
        'background': (row) => row.data['Title'] === 'CEO' ? '#6c757d' : row.data['Title'].includes('President') ? '#adb5bd' :
                row.data['Title'].includes('Director') ? '#ced4da' : row.data['Title'].includes('Manager') ? '#dee2e6' :
                row.data['Title'].includes('Lead') ? '#e9ecef' : row.data['Title'].includes('Senior') ? '#f8f9fa' : null,
        'border-left': (row) => row.data['Title'] === 'CEO' || row.data['Title'].includes('President') ? '2px solid' : null,
        'border-color': (row) => row.data['Title'] === 'CEO' ? '#495057' : null,
        'color': (row) => row.data['Title'] === 'CEO' ? '#fff' : null
    };
}, true);

