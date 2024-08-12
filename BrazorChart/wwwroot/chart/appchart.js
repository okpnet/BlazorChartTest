export function renderChart(element,chartJson) {
    if (window.chartObj) {
        console.log('destroy chartObj');
        window.chartObj.destroy();
    }
    if (element === null || typeof element !== 'object') {
        return;
    }
    console.log("json=" + chartJson);
    window.chartObj = new Chart(element, JSON.parse(chartJson));
};