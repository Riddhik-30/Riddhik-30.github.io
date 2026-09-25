  * {
      margin: 0;
      padding: 0;
      box-sizing: border-box;
    }

    html {
      scroll-behavior: smooth;
    }

    body {
      font-family: Inter, -apple-system, BlinkMacSystemFont, "Segoe UI", sans-serif;
      background: #f7f8fc;
      color: #171923;
      line-height: 1.6;
    }

    a {
      color: inherit;
      text-decoration: none;
    }

    .container {
      width: min(1100px, 90%);
      margin: auto;
    }

    /* NAVBAR */

    nav {
      position: sticky;
      top: 0;
      z-index: 1000;
      background: rgba(247, 248, 252, 0.92);
      backdrop-filter: blur(12px);
      border-bottom: 1px solid #e5e7eb;
    }

    .nav-container {
      min-height: 70px;
      display: flex;
      justify-content: space-between;
      align-items: center;
    }

    .logo {
      font-size: 1.2rem;
      font-weight: 800;
      letter-spacing: -0.5px;
    }

    .logo span {
      color: #c41e3a;
    }

    .nav-links {
      display: flex;
      gap: 28px;
      list-style: none;
      font-size: 0.95rem;
      font-weight: 600;
    }

    .nav-links a {
      color: #4b5563;
      transition: 0.2s ease;
    }

    .nav-links a:hover {
      color: #c41e3a;
    }

    /* HERO */

    .hero {
      min-height: 88vh;
      display: flex;
      align-items: center;
      padding: 80px 0;
    }

    .hero-grid {
      display: grid;
      grid-template-columns: 1.3fr 0.7fr;
      gap: 70px;
      align-items: center;
    }

    .eyebrow {
      display: inline-block;
      padding: 7px 13px;
      border-radius: 999px;
      background: #fff0f2;
      color: #a3162d;
      font-size: 0.85rem;
      font-weight: 700;
      margin-bottom: 20px;
    }

    h1 {
      font-size: clamp(3rem, 7vw, 5.8rem);
      line-height: 0.98;
      letter-spacing: -4px;
      margin-bottom: 25px;
    }

    h1 span {
      color: #c41e3a;
    }

    .hero-description {
      max-width: 650px;
      font-size: 1.15rem;
      color: #5b6472;
      margin-bottom: 30px;
    }

    .buttons {
      display: flex;
      flex-wrap: wrap;
      gap: 14px;
    }

    .button {
      display: inline-block;
      padding: 13px 21px;
      border-radius: 10px;
      font-weight: 700;
      transition: 0.2s ease;
    }

    .button-primary {
      background: #171923;
      color: white;
    }

    .button-primary:hover {
      transform: translateY(-2px);
      background: #c41e3a;
    }

    .button-secondary {
      border: 1px solid #d1d5db;
      background: white;
    }

    .button-secondary:hover {
      transform: translateY(-2px);
      border-color: #c41e3a;
    }

    .hero-card {
      background: white;
      border: 1px solid #e5e7eb;
      border-radius: 24px;
      padding: 30px;
      box-shadow: 0 20px 60px rgba(20, 20, 40, 0.08);
    }

    .hero-card-top {
      display: flex;
      align-items: center;
      gap: 15px;
      margin-bottom: 25px;
    }

    .avatar {
      width: 60px;
      height: 60px;
      border-radius: 18px;
      background: #c41e3a;
      color: white;
      display: grid;
      place-items: center;
      font-size: 1.3rem;
      font-weight: 800;
    }

    .hero-card h3 {
      font-size: 1.05rem;
    }

    .hero-card p {
      color: #6b7280;
      font-size: 0.9rem;
    }

    .interest {
      padding: 13px 0;
      border-top: 1px solid #eee;
      color: #4b5563;
    }

    /* SECTIONS */

    section {
      padding: 100px 0;
    }

    .section-label {
      color: #c41e3a;
      font-size: 0.8rem;
      font-weight: 800;
      text-transform: uppercase;
      letter-spacing: 2px;
      margin-bottom: 10px;
    }

    .section-title {
      font-size: 2.5rem;
      letter-spacing: -1.5px;
      margin-bottom: 15px;
    }

    .section-intro {
      color: #68707d;
      max-width: 700px;
      margin-bottom: 45px;
    }

    /* ABOUT */

    .about-grid {
      display: grid;
      grid-template-columns: 1fr 1fr;
      gap: 60px;
    }

    .about-text p {
      margin-bottom: 18px;
      color: #59616e;
    }

    .facts {
      display: grid;
      gap: 15px;
    }

    .fact {
      padding: 20px;
      background: white;
      border: 1px solid #e5e7eb;
      border-radius: 14px;
    }

    .fact strong {
      display: block;
      margin-bottom: 4px;
    }

    .fact span {
      color: #6b7280;
      font-size: 0.93rem;
    }

    /* PROJECTS */

    .projects {
      display: grid;
      grid-template-columns: repeat(3, 1fr);
      gap: 22px;
    }

    .project {
      background: white;
      border: 1px solid #e5e7eb;
      border-radius: 18px;
      padding: 25px;
      transition: 0.25s ease;
    }

    .project:hover {
      transform: translateY(-5px);
      box-shadow: 0 15px 40px rgba(20, 20, 40, 0.08);
    }

    .project-number {
      color: #c41e3a;
      font-weight: 800;
      margin-bottom: 20px;
    }

    .project h3 {
      margin-bottom: 10px;
    }

    .project p {
      color: #69717e;
      font-size: 0.93rem;
      margin-bottom: 20px;
    }

    .tags {
      display: flex;
      flex-wrap: wrap;
      gap: 7px;
    }

    .tag {
      background: #f0f1f4;
      padding: 5px 9px;
      border-radius: 6px;
      font-size: 0.75rem;
      font-weight: 700;
      color: #4b5563;
    }

    /* LEARNING */

    .timeline {
      border-left: 2px solid #dddfe4;
      padding-left: 30px;
      display: grid;
      gap: 35px;
    }

    .timeline-item {
      position: relative;
    }

    .timeline-item::before {
      content: "";
      position: absolute;
      left: -40px;
      top: 5px;
      width: 16px;
      height: 16px;
      border-radius: 50%;
      background: #c41e3a;
      border: 4px solid #f7f8fc;
    }

    .timeline-date {
      color: #c41e3a;
      font-size: 0.82rem;
      font-weight: 800;
      text-transform: uppercase;
      letter-spacing: 1px;
    }

    .timeline-item h3 {
      margin: 5px 0;
    }

    .timeline-item p {
      color: #68707d;
    }

    /* SKILLS */

    .skills {
      display: grid;
      grid-template-columns: repeat(3, 1fr);
      gap: 20px;
    }

    .skill-card {
      background: white;
      border: 1px solid #e5e7eb;
      border-radius: 16px;
      padding: 25px;
    }

    .skill-card h3 {
      margin-bottom: 10px;
    }

    .skill-card p {
      color: #68707d;
      font-size: 0.92rem;
    }

    /* CONTACT */

    .contact-box {
      background: #171923;
      color: white;
      border-radius: 25px;
      padding: 60px;
      text-align: center;
    }

    .contact-box h2 {
      font-size: 2.7rem;
      margin-bottom: 15px;
      letter-spacing: -1px;
    }

    .contact-box p {
      color: #c7cbd3;
      max-width: 600px;
      margin: 0 auto 25px;
    }

    .contact-box .button {
      background: white;
      color: #171923;
    }

    /* FOOTER */

    footer {
      padding: 35px 0;
      color: #777f8c;
      font-size: 0.85rem;
      text-align: center;
    }

    /* MOBILE */

    @media (max-width: 850px) {
      .nav-links {
        display: none;
      }

      .hero-grid,
      .about-grid {
        grid-template-columns: 1fr;
      }

      .projects,
      .skills {
        grid-template-columns: 1fr;
      }

      .hero {
        padding-top: 60px;
      }

      h1 {
        letter-spacing: -2px;
      }

      .contact-box {
        padding: 40px 25px;
      }
    }
