<!-- cd greenshop
    npm run dev -->

<template>
    <header>
        <div class="header">
            <div class="name-shop" >
                <img src="@/assets/logo.png" alt="GREENSHOP_LOGO">
                <p>GREENSHOP</p>
            </div>
            <div class="nav-links">
                <button class="nav-buttons">
                    <RouterLink class="nav-link" to="/">Home</RouterLink>
                </button>
                <button class="nav-buttons">
                    <RouterLink class="nav-link" to="/">Shop</RouterLink>
                </button>
                <button class="nav-buttons">
                    <RouterLink class="nav-link" to="/">Plant care</RouterLink>
                </button>
                <button class="nav-buttons">
                    <RouterLink class="nav-link" to="/">Blogs</RouterLink>
                </button>
            </div>
            <div class="nav-links-right">
                <button class="nav-buttons-right">
                    <img src="@/assets/search-icon.png" alt="Поиск">
                </button>
                <button class="nav-buttons-right">
                    <img src="@/assets/cart-icon.png" alt="Корзина">
                </button>
                <button class="nav-buttons-right-login">
                    <img src="@/assets/login.png" alt="Вход">
                    <span style="margin-left: 5px;">Login</span>
                </button>
            </div>
        </div>
        <hr class="horizontal-hr">
    </header>

    <div class="banner">
        <div class="banner-text">
            <div style="padding: 0; margin: 0;">WELCOME TO GREENSHOP</div>
            <h1 style="padding: 0; margin: 0; font-size: 55px;">LET'S MAKE A</h1>
            <h1 style="padding: 0; margin: 0; font-size: 55px;">BETTER <span>PLANET</span></h1>
            <div style="max-width: 580px;">We are online plant shop offering a wide range of cheap and trendy plants. Use our plants to create an unique Urdan Jungle. Order your favorite plants!</div>
            <div style="display: flex; justify-content: start;">
                <button class="green-button" style="height: 40px; width: 100px; margin-top: 30px;">
                    <RouterLink class="green-button-link" to="/">SHOP NOW</RouterLink>
                </button>
            </div>
        </div>
        <div class="banner-img">
            <img src="@/assets/garden_for_banner.png" alt="garden">
        </div>
    </div>

    <div class="main-block">
        <aside class="filters">
            <div class="filter-categories">
                <div style="font-weight: bold;">Categories</div>
                <div class="selected">House Plants (33)</div>
                <div class="selected">Potter Plants (12)</div>
                <div class="selected">Seeds (65)</div>
                <div class="selected">Small Plants (39)</div>
                <div class="selected">Big Plants (23)</div>
                <div class="selected">Succulents (17)</div>
                <div class="selected">Trerrariums (19)</div>
                <div class="selected">Gardening (13)</div>
                <div class="selected">Accessories (18)</div>
            </div>
            <div class="filter-price">
                <div style="font-weight: bold;">Price Range</div>
                <div class="prices">
                    <input type="range" min="39" style="width: 200px; accent-color: #46A358">
                    <div style="padding: 0; margin: 0;">Price: <span style="color: #46A358;">$</span></div>
                    <button class="green-button" style="height: 35px; width: 90px;">
                        <RouterLink class="green-button-link" to="/">Filter</RouterLink>
                    </button>
                </div>
            </div>
            <div class="filter-size">
                <div style="font-weight: bold;">Size</div>
                <div class="selected">Small (119)</div>
                <div class="selected">Medium (86)</div>
                <div class="selected">Large (78)</div>
            </div>
            <img src="@/assets/super_sale.png" alt="super_sale">
            <img src="@/assets/super_sale_2.png" alt="super_sale">
        </aside>

        <div class="product-section">
            <div class="product-header">
                <div style="display: flex; gap: 35px;">
                    <div>All Plants</div>
                    <div>New Arrivals</div>
                    <div>Sale</div>
                </div>
                <div style="display: flex; gap: 5px;">
                    <div>Short by:</div>
                    <select name="sort" id="sort" style="border: none;">
                        <option value="default">Default sorting</option>
                        <option value="asc">Low to High</option>
                        <option value="desc">High to Low</option>
                    </select>
                </div>
            </div>
            <div class="product-grid">
                <div class="product-card">
                    <img src="@/assets/card_1.png" alt="1" class="product-image">
                    <div class="product-buttons">
                        <button class="product-button" value="shop">
                            <img src="@/assets/shopping.png" alt="shop">
                        </button>
                        <button class="product-button" value="like">
                            <img src="@/assets/heart.png" alt="like">
                        </button>
                        <button class="product-button" value="search">
                            <img src="@/assets/view.png" alt="search">
                        </button>
                    </div>
                    <div class="product-name">Barberton Daisy</div>
                    <div class="product-price">$119.00</div>
                </div>
                <div class="product-card">
                    <img src="@/assets/card_2.png" alt="2" class="product-image">
                    <div class="product-buttons">
                        <button class="product-button" value="shop">
                            <img src="@/assets/shopping.png" alt="shop">
                        </button>
                        <button class="product-button" value="like">
                            <img src="@/assets/heart.png" alt="like">
                        </button>
                        <button class="product-button" value="search">
                            <img src="@/assets/view.png" alt="search">
                        </button>
                    </div>
                    <div class="product-name">Angel Wing Begonia</div>
                    <div class="product-price">$169.00</div>
                </div>
                <div class="product-card">
                    <div class="sale">13% OFF</div>
                    <img src="@/assets/card_3.png" alt="3" class="product-image">
                    <div class="product-buttons">
                        <button class="product-button" value="shop">
                            <img src="@/assets/shopping.png" alt="shop">
                        </button>
                        <button class="product-button" value="like">
                            <img src="@/assets/heart.png" alt="like">
                        </button>
                        <button class="product-button" value="search">
                            <img src="@/assets/view.png" alt="search">
                        </button>
                    </div>
                    <div class="product-name">African Violet</div>
                    <div class="product-price">$199.00 <span class="product-old-price">$229.00</span></div>
                </div>
                <div class="product-card">
                    <img src="@/assets/card_4.png" alt="4" class="product-image">
                    <div class="product-buttons">
                        <button class="product-button" value="shop">
                            <img src="@/assets/shopping.png" alt="shop">
                        </button>
                        <button class="product-button" value="like">
                            <img src="@/assets/heart.png" alt="like">
                        </button>
                        <button class="product-button" value="search">
                            <img src="@/assets/view.png" alt="search">
                        </button>
                    </div>
                    <div class="product-name">Beach Spider Lily</div>
                    <div class="product-price">$129.00</div>
                </div>
                <div class="product-card">
                    <img src="@/assets/card_5.png" alt="5" class="product-image">
                    <div class="product-buttons">
                        <button class="product-button" value="shop">
                            <img src="@/assets/shopping.png" alt="shop">
                        </button>
                        <button class="product-button" value="like">
                            <img src="@/assets/heart.png" alt="like">
                        </button>
                        <button class="product-button" value="search">
                            <img src="@/assets/view.png" alt="search">
                        </button>
                    </div>
                    <div class="product-name">Blushing Bromeliad</div>
                    <div class="product-price">$139.00</div>
                </div>
                <div class="product-card">
                    <img src="@/assets/card_6.png" alt="6" class="product-image">
                    <div class="product-buttons">
                        <button class="product-button" value="shop">
                            <img src="@/assets/shopping.png" alt="shop">
                        </button>
                        <button class="product-button" value="like">
                            <img src="@/assets/heart.png" alt="like">
                        </button>
                        <button class="product-button" value="search">
                            <img src="@/assets/view.png" alt="search">
                        </button>
                    </div>
                    <div class="product-name">Aluminum Plant</div>
                    <div class="product-price">$179.00</div>
                </div>
                <div class="product-card">
                    <img src="@/assets/card_7.png" alt="7" class="product-image">
                    <div class="product-buttons">
                        <button class="product-button" value="shop">
                            <img src="@/assets/shopping.png" alt="shop">
                        </button>
                        <button class="product-button" value="like">
                            <img src="@/assets/heart.png" alt="like">
                        </button>
                        <button class="product-button" value="search">
                            <img src="@/assets/view.png" alt="search">
                        </button>
                    </div>
                    <div class="product-name">Bird's Nest Fern</div>
                    <div class="product-price">$99.00</div>
                </div>
                <div class="product-card">
                    <img src="@/assets/card_8.png" alt="8" class="product-image">
                    <div class="product-buttons">
                        <button class="product-button" value="shop">
                            <img src="@/assets/shopping.png" alt="shop">
                        </button>
                        <button class="product-button" value="like">
                            <img src="@/assets/heart.png" alt="like">
                        </button>
                        <button class="product-button" value="search">
                            <img src="@/assets/view.png" alt="search">
                        </button>
                    </div>
                    <div class="product-name">Broadleaf Lady Palm</div>
                    <div class="product-price">$59.00</div>
                </div>
                <div class="product-card">
                    <img src="@/assets/card_9.png" alt="9" class="product-image">
                    <div class="product-buttons">
                        <button class="product-button" value="shop">
                            <img src="@/assets/shopping.png" alt="shop">
                        </button>
                        <button class="product-button" value="like">
                            <img src="@/assets/heart.png" alt="like">
                        </button>
                        <button class="product-button" value="search">
                            <img src="@/assets/view.png" alt="search">
                        </button>
                    </div>
                    <div class="product-name">Chinese Evergreen</div>
                    <div class="product-price">$39.00</div>
                </div>
            </div>
            <div class="pagination">
                <button class="pagination-button" style="margin: 5px;">
                    <RouterLink class="pagination-button-link" to="/">1</RouterLink>
                </button>
                <button class="pagination-button" style="margin: 5px;">
                    <RouterLink class="pagination-button-link" to="/">2</RouterLink>
                </button>
                <button class="pagination-button" style="margin: 5px;">
                    <RouterLink class="pagination-button-link" to="/">3</RouterLink>
                </button>
                <button class="pagination-button" style="margin: 5px;">
                    <RouterLink class="pagination-button-link" to="/">4</RouterLink>
                </button>
                <button class="pagination-button" style="margin: 5px;">
                    <RouterLink class="pagination-button-link" to="/">></RouterLink>
                </button>
            </div>
        </div>
    </div>
    

    <div class="find-more">
        <div class="find-more-section">
            <img src="@/assets/for_section_1.png" alt="section_1">
            <div class="text-section">
                <div style="font-weight: bold; font-size: 21px; max-width: 170px;">SUMMER CACTUS & SUCCULENTS</div>
                <div style="color: #AFAFAF; max-width: 400px;">We are an online plant shop offering a wide range of cheap and trendy plants</div>
                <button class="green-button" style="height: 40px; width: 140px;">
                    <RouterLink class="green-button-link" to="/">Find more →</RouterLink>
                </button>
            </div>
        </div>
        <div class="find-more-section">
            <img src="@/assets/for_section_2.png" alt="section_2">
            <div class="text-section">
                <div style="font-weight: bold; font-size: 21px; max-width: 170px;">STYLING TRENDS & MUCH MORE</div>
                <div style="color: #AFAFAF; max-width: 400px;">We are an online plant shop offering a wide range of cheap and trendy plants</div>
                <button class="green-button" style="height: 40px; width: 140px;">
                    <RouterLink class="green-button-link" to="/">Find more →</RouterLink>
                </button>
            </div>
        </div>
    </div>

    <div class="blogs">
        <div style="font-weight: bold; font-size: 22px;">Our Blog Posts</div>
        <div style="color: #AFAFAF;">We are an online plant shop offering a wide range of cheap and trendly plants.</div>
        <div class="blog-section">
            <div class="blog-inner-container">
                <img src="@/assets/for_blog_1.png" alt="01">
                <div style="color: #46A358;">September 12 | Read in 6 minutes</div>
                <div style="font-weight: bold; font-size: 20px;">Cactus & Succulent Care Tips</div>
                <div style="color: #AFAFAF">Cacti are Succulents are easy care plants for any home or patio.</div>
                <button class="transparent-button" style="margin: 5px;">
                    <RouterLink class="transparent-button-link-2" to="/">Read More →</RouterLink>
                </button>
            </div>
            <div class="blog-inner-container">
                <img src="@/assets/for_blog_2.png" alt="02">
                <div style="color: #46A358;">September 13 | Read in 2 minutes</div>
                <div style="font-weight: bold; font-size: 20px;">Top 10 Succulents for Your Home</div>
                <div style="color: #AFAFAF">Best in hanging baskets. Prefers medium to high light.</div>
                <button class="transparent-button" style="margin: 5px;">
                    <RouterLink class="transparent-button-link-2" to="/">Read More →</RouterLink>
                </button>
            </div>
            <div class="blog-inner-container">
                <img src="@/assets/for_blog_3.png" alt="03">
                <div style="color: #46A358;">September 15 | Read in 3 minutes</div>
                <div style="font-weight: bold; font-size: 20px;">Cacti & Succulent Care Tips</div>
                <div style="color: #AFAFAF">Cacti are Succulents thrive in containers and because most are...</div>
                <button class="transparent-button" style="margin: 5px;">
                    <RouterLink class="transparent-button-link-2" to="/">Read More →</RouterLink>
                </button>
            </div>
            <div class="blog-inner-container">
                <img src="@/assets/for_blog_4.png" alt="04">
                <div style="color: #46A358;">September 15 | Read in 2 minutes</div>
                <div style="font-weight: bold; font-size: 20px;">Best Houseplants Room By Room</div>
                <div style="color: #AFAFAF">The benefits of houseplants are endless. Un addition to...</div>
                <button class="transparent-button" style="margin: 5px;">
                    <RouterLink class="transparent-button-link-2" to="/">Read More →</RouterLink>
                </button>
            </div>
        </div>
    </div>

    <footer>
        <div class="footer-container-1">
            <div class="footer-inner-container-1" style="margin-left: 20px;">
                <div>
                    <img src="@/assets/garden_care.png" alt="garden_care">
                    <div style="font-size: 17px; font-weight: bold;">Garden Care</div>
                    <div style="max-width: 220px; font-size: 14px; color: #AFAFAF;">We are an online plant shop offering a wide range of cheap and trendy plants.</div>
                </div>
                <hr class="vertical-hr">
            </div>
            <div class="footer-inner-container-1">
                <div>
                    <img src="@/assets/plant_renovation.png" alt="plant_renovation">
                    <div style="font-size: 17px; font-weight: bold;">Plant Renovation</div>
                    <div style="max-width: 220px; font-size: 14px; color: #AFAFAF;">We are an online plant shop offering a wide range of cheap and trendy plants.</div>
                </div>
                <hr class="vertical-hr">
            </div>
            <div class="footer-inner-container-1">
                <div>
                    <img src="@/assets/watering_graden.png" alt="watering_graden">
                    <div style="font-size: 17px; font-weight: bold;">Watering Graden</div>
                    <div style="max-width: 220px; font-size: 14px; color: #AFAFAF;">We are an online plant shop offering a wide range of cheap and trendy plants.</div>
                </div>
            </div>
            <div class="footer-inner-container-newsletter">
                <div style="font-weight: bold; font-size: 18px;">Would you like to join newsletters?</div>
                <div class="footer-inner-container-newsletter-email">
                    <input type="email" placeholder="enter your email address...">
                    <button>Join</button>
                </div>
                <div style="color: #AFAFAF; max-width: 410px;">We usually post offers and challenges in newsletter. We're your online houseplant destination. We offer a wide range of houseplants and accessories shipped directly from our (green)house to yours!</div>
            </div>
        </div>
        <div class="footer-container-2">
            <div class="name-shop">
                <img src="@/assets/logo.png" alt="GREENSHOP_LOGO">
                <p>GREENSHOP</p>
            </div>
            <div class="footer-inner-container-2">
                <img src="@/assets/location.png" alt="location">
                <div style="max-width: 200px;">70 West Buckingham Ave. Farmigdale, NY 11735</div>
            </div>
            <div class="footer-inner-container-2">
                <img src="@/assets/email.png" alt="email">
                <div>contact@greenshop.com</div>
            </div>
            <div class="footer-inner-container-2">
                <img src="@/assets/calling.png" alt="calling">
                <div>+88 01911 717 490</div>
            </div>
        </div>
        <div class="footer-container-3">
            <div class="footer-inner-container-3">
                <div style="font-weight: bold; font-size: 18px;">My Account</div>
                <button class="transparent-button">
                    <RouterLink class="transparent-button-link" to="/">My Account</RouterLink>
                </button>
                <button class="transparent-button">
                    <RouterLink class="transparent-button-link" to="/">Our stores</RouterLink>
                </button>
                <button class="transparent-button">
                    <RouterLink class="transparent-button-link" to="/">Contact us</RouterLink>
                </button>
                <button class="transparent-button">
                    <RouterLink class="transparent-button-link" to="/">Career</RouterLink>
                </button>
                <button class="transparent-button">
                    <RouterLink class="transparent-button-link" to="/">Specials</RouterLink>
                </button>
            </div>
            <div class="footer-inner-container-3">
                <div style="font-weight: bold; font-size: 18px;">Help & Guide</div>
                <button class="transparent-button">
                    <RouterLink class="transparent-button-link" to="/">Help Center</RouterLink>
                </button>
                <button class="transparent-button">
                    <RouterLink class="transparent-button-link" to="/">How to Buy</RouterLink>
                </button>
                <button class="transparent-button">
                    <RouterLink class="transparent-button-link" to="/">Shipping & Delivery</RouterLink>
                </button>
                <button class="transparent-button">
                    <RouterLink class="transparent-button-link" to="/">Product Policy</RouterLink>
                </button>
                <button class="transparent-button">
                    <RouterLink class="transparent-button-link" to="/">How to Return</RouterLink>
                </button>
            </div>
            <div class="footer-inner-container-3">
                <div style="font-weight: bold; font-size: 18px;">Categories</div>
                <button class="transparent-button">
                    <RouterLink class="transparent-button-link" to="/">House Plants</RouterLink>
                </button>
                <button class="transparent-button">
                    <RouterLink class="transparent-button-link" to="/">Potter Plants</RouterLink>
                </button>
                <button class="transparent-button">
                    <RouterLink class="transparent-button-link" to="/">Seeds</RouterLink>
                </button>
                <button class="transparent-button">
                    <RouterLink class="transparent-button-link" to="/">Small Plants</RouterLink>
                </button>
                <button class="transparent-button">
                    <RouterLink class="transparent-button-link" to="/">Accessories</RouterLink>
                </button>
            </div>
            <div class="footer-inner-container-3">
                <div style="font-weight: bold; font-size: 18px;">Social Media</div>
                <div style="display: flex;">
                    <button class="footer-inner-container-3-buttons">
                        <img src="@/assets/facebook.png" alt="facebook">
                    </button>
                    <button class="footer-inner-container-3-buttons">
                        <img src="@/assets/instagram.png" alt="instagram">
                    </button>
                    <button class="footer-inner-container-3-buttons">
                        <img src="@/assets/twitter.png" alt="twitter">
                    </button>
                    <button class="footer-inner-container-3-buttons">
                        <img src="@/assets/linkedin.png" alt="linkedin">
                    </button>
                </div>
                <div style="font-weight: bold; font-size: 18px;">We accept</div>
                <img src="@/assets/pay.png" alt="pay">
            </div>
        </div>
        <div class="footer-container-4">
            <div>© 2021 GreenShop. All Rights Reserved.</div>
        </div>
    </footer>
</template>