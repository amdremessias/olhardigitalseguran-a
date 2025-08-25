<!DOCTYPE html>
<html lang="pt-br">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta name="description" content="Clayton Eletricista: Instalações elétricas, manutenção, e instalação de ar condicionado. Atendimento em Ourinhos e região.">
    <title>Clayton Eletricista | Soluções Elétricas Completas em Ourinhos</title>
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.0.0-beta3/css/all.min.css">
    <style>
        /* Estilos Globais e de Fundo */
        :root {
            --dark-bg: #121212;
            --main-color: #ffc107; /* Amarelo dourado */
            --light-text: #e0e0e0;
            --secondary-bg: rgba(30, 30, 30, 0.9);
            --border-radius: 8px;
        }

        body {
            background-color: var(--dark-bg);
            background-image: url('https://images.unsplash.com/photo-1582213235336-d44b2074e2d3?q=80&w=2071&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D');
            background-size: cover;
            background-position: center center;
            background-attachment: fixed;
            color: var(--light-text);
            font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif;
            margin: 0;
            padding: 0;
            line-height: 1.6;
            text-align: center;
        }

        body::before {
            content: '';
            position: fixed;
            top: 0;
            left: 0;
            width: 100%;
            height: 100%;
            background: rgba(0, 0, 0, 0.8);
            z-index: -1;
        }

        /* Estrutura da Página */
        .container {
            max-width: 1100px;
            margin: 40px auto;
            padding: 20px;
        }

        header, footer, .main-content, .service-card, .contact-section {
            background: var(--secondary-bg);
            border-radius: var(--border-radius);
            margin: 20px auto;
            box-shadow: 0 4px 15px rgba(0, 0, 0, 0.5);
            backdrop-filter: blur(5px);
        }

        header {
            padding: 30px 20px;
            text-shadow: 2px 2px 4px rgba(0, 0, 0, 0.7);
        }

        header h1 {
            color: var(--main-color);
            font-size: 3em;
            margin: 0;
            font-weight: 700;
        }

        header p {
            color: var(--light-text);
            font-size: 1.2em;
            font-weight: 300;
        }

        /* Conteúdo Principal */
        main {
            padding: 20px;
        }

        h2 {
            color: var(--main-color);
            font-size: 2.2em;
            margin-bottom: 20px;
            border-bottom: 2px solid var(--main-color);
            padding-bottom: 10px;
            display: inline-block;
        }

        p {
            font-size: 1.1em;
            max-width: 800px;
            margin: 20px auto;
        }

        /* Seção de Serviços */
        .service-grid {
            display: grid;
            grid-template-columns: repeat(auto-fit, minmax(280px, 1fr));
            gap: 25px;
            padding: 20px;
        }

        .service-card {
            background: rgba(40, 40, 40, 0.9);
            padding: 30px;
            transition: transform 0.3s ease, box-shadow 0.3s ease;
            text-align: left;
            border-left: 5px solid var(--main-color);
        }

        .service-card:hover {
            transform: translateY(-10px);
            box-shadow: 0 10px 25px rgba(255, 193, 7, 0.4);
        }

        .service-card i {
            font-size: 2.5em;
            color: var(--main-color);
            margin-bottom: 15px;
            display: block;
        }

        .service-card h3 {
            color: var(--light-text);
            font-size: 1.5em;
            margin-top: 0;
        }

        .service-card p {
            font-size: 1em;
            margin: 0;
        }

        /* Seção de Contato */
        .contact-section {
            padding: 40px;
        }

        .whatsapp-link {
            display: inline-flex;
            align-items: center;
            background-color: #25D366;
            color: #fff;
            padding: 15px 35px;
            border-radius: 50px;
            text-decoration: none;
            font-weight: bold;
            font-size: 1.2em;
            transition: background-color 0.3s ease, transform 0.3s ease;
            box-shadow: 0 4px 10px rgba(0, 0, 0, 0.4);
            margin-top: 20px;
        }

        .whatsapp-link:hover {
            background-color: #1DA851;
            transform: scale(1.05);
        }

        .whatsapp-link i {
            margin-right: 10px;
            font-size: 1.5em;
        }

        /* Rodapé */
        footer {
            padding: 20px;
            color: var(--main-color);
        }
    </style>
</head>
<body>
    <header>
        <h1>Clayton Eletricista</h1>
        <p>Sua segurança e conforto são a nossa prioridade. Atendimento em Ourinhos e região.</p>
    </header>

    <main>
        <section id="about" class="container main-content">
            <h2>Soluções Elétricas Completas</h2>
            <p>Se você busca um serviço elétrico confiável e seguro, chegou ao lugar certo. Nós somos o Clayton Eletricista, sua solução para qualquer necessidade elétrica em sua casa ou empresa. Com anos de experiência e um compromisso inabalável com a excelência, garantimos um serviço de qualidade, com foco total na sua segurança e na eficiência energética.</p>
        </section>

        <section id="services" class="container">
            <h2>Nossos Serviços</h2>
            <div class="service-grid">
                <article class="service-card">
                    <i class="fas fa-bolt"></i>
                    <h3>Instalações Elétricas</h3>
                    <p>Realizamos a instalação completa da parte elétrica de imóveis novos, além de reformas e troca de fiação, seguindo todas as normas de segurança.</p>
                </article>

                <article class="service-card">
                    <i class="fas fa-tools"></i>
                    <h3>Manutenção e Reparos</h3>
                    <p>Problemas com tomadas, disjuntores ou curtos-circuitos? Resolvemos de forma rápida e eficaz. Nossa manutenção garante o bom funcionamento do seu sistema elétrico.</p>
                </article>

                <article class="service-card">
                    <i class="fas fa-fan"></i>
                    <h3>Instalação de Ar Condicionado</h3>
                    <p>Instalamos e fazemos a manutenção de aparelhos de ar condicionado de todas as marcas e modelos, garantindo máxima eficiência e economia de energia.</p>
                </article>

                <article class="service-card">
                    <i class="fas fa-cogs"></i>
                    <h3>Quadros de Distribuição</h3>
                    <p>Substituímos disjuntores antigos e organizamos quadros de luz para maior segurança e facilidade na gestão da energia do seu imóvel.</p>
                </article>

                <article class="service-card">
                    <i class="fas fa-lightbulb"></i>
                    <h3>Iluminação e Pontos de Força</h3>
                    <p>Instalações de chuveiros, tomadas, interruptores e pontos de luz com acabamento perfeito e o funcionamento correto de cada item.</p>
                </article>

                <article class="service-card">
                    <i class="fas fa-file-invoice"></i>
                    <h3>Laudos e Análise de Projetos</h3>
                    <p>Fornecemos laudos técnicos e analisamos projetos elétricos, assegurando que tudo esteja conforme a norma e em perfeitas condições de uso.</p>
                </article>
            </div>
        </section>
        
        <section id="contact" class="container contact-section">
            <h2>Pronto para iluminar seu espaço com segurança?</h2>
            <p>Valorizamos a transparência, o profissionalismo e, acima de tudo, a sua tranquilidade. Nossa missão é oferecer soluções elétricas completas, de forma segura e duradoura.</p>
            <a href="https://wa.me/5514996243023" target="_blank" class="whatsapp-link">
                <i class="fab fa-whatsapp"></i>
                Chamar no WhatsApp
            </a>
        </section>
    </main>

    <footer>
        <p>&copy; 2025 | Clayton Eletricista | Todos os direitos reservados.</p>
    </footer>
</body>
</html>
