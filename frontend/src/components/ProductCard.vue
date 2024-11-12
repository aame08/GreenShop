<script setup>
defineProps({
  image: String,
  name: String,
  price: String,
  oldPrice: String,
  discount: String
});
</script>

<template>
  <div class="product-card">
    <div v-if="discount" class="sale">{{ discount }} OFF</div>
    <img :src="image" :alt="name" class="product-image">
    <div class="product-buttons">
      <button class="product-button" value="shop">
        <img src="@/assets/product_cards/shopping.png" alt="shop">
      </button>
      <button class="product-button" value="like">
        <img src="@/assets/product_cards/heart.png" alt="like">
      </button>
      <button class="product-button" value="search">
        <img src="@/assets/product_cards/view.png" alt="search">
      </button>
    </div>
    <div class="product-name">{{ name }}</div>
    <div class="product-price">
      {{ price }}
      <span v-if="oldPrice" class="product-old-price">{{ oldPrice }}</span>
    </div>
  </div>
</template>

<style scoped>
.product-card {
    background-color: #FBFBFB;
    display: flex;
    flex-direction: column;
    padding: 5px;
}

.sale {
    width: 80px;
    height: 25px;
    background-color: #46A358;
    color: white;
    text-align: center;
}

.product-card:hover {
    border-top: 2px solid #46A358;
}

.product-image {
    height: 200px;
    object-fit: contain;
}

.product-buttons {
    flex-direction: row;
    justify-content: center;
    gap: 10px;
    margin-top: 10px;
    display: none;
}

.product-card:hover .product-buttons {
    display: flex;
}

.product-button {
    display: flex;
    align-items: center;
    height: 35px;
    cursor: pointer;
    border: none;
    background: none;
}

.product-name {
    margin-top: 5px;
    font-size: 18px;
}

.product-price {
    color: #46A358;
    font-weight: bold;
}

.product-old-price {
    text-decoration: line-through;
    font-size: 14px;
    color: #CBCBCB;
}
</style>

<!-- 
import ProductCard from '../components/ProductCard.vue'
  import card1 from '@/assets/product_cards/card_1.png'
  import card2 from '@/assets/product_cards/card_2.png'
  import card3 from '@/assets/product_cards/card_3.png'
  import card4 from '@/assets/product_cards/card_4.png'
  import card5 from '@/assets/product_cards/card_5.png'
  import card6 from '@/assets/product_cards/card_6.png'
  import card7 from '@/assets/product_cards/card_7.png'
  import card8 from '@/assets/product_cards/card_8.png'
  import card9 from '@/assets/product_cards/card_9.png'
<ProductCard 
          :image="card1" 
          name="Barberton Daisy" 
          price="$119.00"/>
        <ProductCard 
          :image="card2" 
          name="Angel Wing Begonia" 
          price="$169.00"/>
        <ProductCard 
          :image="card3" 
          name="African Violet" 
          price="$199.00" 
          oldPrice="$229.00"
          discount="13%"/>
        <ProductCard 
          :image="card4" 
          name="Beach Spider Lily" 
          price="$129.00"/>
        <ProductCard 
          :image="card5" 
          name="Blushing Bromeliad" 
          price="$139.00"/>
        <ProductCard 
          :image="card6" 
          name="Aluminum Plant" 
          price="$179.00"/>
        <ProductCard 
          :image="card7" 
          name="Bird's Nest Fern" 
          price="$99.00"/>
        <ProductCard 
          :image="card8" 
          name="Broadleaf Lady Palm" 
          price="$59.00"/>
        <ProductCard 
          :image="card9" 
          name="Chinese Evergreen" 
          price="$39.00"/> -->