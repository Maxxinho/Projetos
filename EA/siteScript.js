//TRANSIÇÃO SUAVE ENTRE PÁGINAS
document.addEventListener('DOMContentLoaded', () => {
    document.body.classList.add('fade-in');

    const links = document.querySelectorAll('a');
    links.forEach(link => {
        link.addEventListener('click', (event) => {
            if (link.href !== window.location.href && link.target !== '_blank') {
                event.preventDefault();
                document.body.classList.remove('fade-in');
                document.body.classList.add('fade-out');

                setTimeout(() => {
                    window.location.href = link.href;
                }, 0);
            }
        });
    });
});

//ANIMAÇÃO REGRESSIVA PARA O NÚMERO DE ANO DE FUNDAÇÃO DA EA - SOBRE/HISTÓRIA
const contador = document.querySelectorAll('.contador');
const delay = 1000;

contador.forEach((contador) => {
    contador.innerText = '2026';
        
        activated = true;
    
        const updateCounter = ()=>{
            const target = +contador.getAttribute('data-target');
            const c = +contador.innerText;
            const increment = - (2025 - target) / 5000;

            if (c > target){
                contador.innerText = `${Math.floor(c + increment)}`;
                setTimeout(updateCounter, 42);

            } else {
                contador.innerText = target;
            }
        }
    setTimeout(updateCounter, delay);
});


//ANIMAÇÃO TEXTO "55 BILHÕES" - SOBRE/ATUALIDADE
document.addEventListener("DOMContentLoaded", () => {

	const observer = new IntersectionObserver(entries => {
	  entries.forEach(entry => {
		if (entry.isIntersecting) {
		  entry.target.classList.add('in-view');
		  return;
		}
		entry.target.classList.remove('in-view');
	  });
	});

	const allAnimatedElements = document.querySelectorAll('.animate');

	allAnimatedElements.forEach((element) => observer.observe(element));
}); 