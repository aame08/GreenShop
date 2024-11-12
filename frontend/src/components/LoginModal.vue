<script setup>
import { defineProps, ref } from 'vue';
import axios from "axios";

const props = defineProps({
  isVisible: Boolean,
});

const emit = defineEmits(['close', 'switchToRegister']);

const switchToRegister = () => {
  emit('switchToRegister');
};

const email = ref('');
const password = ref('');
const message = ref('');
const authorize = async () => {
  const response = await axios.get(`https://localhost:7141/api/Users/${email.value}/${password.value}`);
  if (response.status == 200) {
    message.value = `Добро пожаловать, ${response.data.username}.`;
  }
  else if (response.status == 404) {
    message.value = 'Пользователь не найден.';
  }
  console.log(message.value);
}
</script>

<template>
  <div class="modal-overlay" v-if="isVisible">
    <div class="modal-content">
      <div class="modal-header">
        <button class="button-close" @click="$emit('close')">✕</button>
        <div class="buttons">
          <div style="font-size: 18px; color: #46A358;">Login</div>
          <div>|</div>
          <button class="transparent-button" @click="switchToRegister">Register</button>
        </div>
      </div>
      <form @submit.prevent="authorize" class="input-container">
        <div>Enter your username and password to login.</div>
        <input type="email" placeholder="almanun_uxui@outlook.com" required v-model="email">
        <div class="password-container">
          <input type="password" placeholder="***********" style="width: 270px;" required v-model="password">
          <button class="toggle">
            <img src="@/assets/login_register/hide_password.png" alt="toggle">
          </button>
        </div>
        <button class="transparent-button" style="font-size: 14px; align-self: flex-end;">Forgot Password?</button>
        <button type="submit" class="button-login">Login</button>
      </form>
      <div class="another-login">
        <div class="login"><span>Or login with</span></div>
        <button class="social-button">
          <img src="@/assets/login_register/google_login.png" alt="google">
          <div>Login with Google</div>
        </button>
        <button class="social-button">
          <img src="@/assets/login_register/facebook_login.png" alt="facebook">
          <div>Login with Facebook</div>
        </button>
      </div>
    </div>
  </div>
</template>
  
<style scoped>
.modal-overlay {
  background: rgba(0, 0, 0, 0.5);
  display: flex;
  justify-content: center;
  align-items: center;
  left: 0;
  position: fixed;
  right: 0;
  top: 0;
  bottom: 0;
  z-index: 1000;
}
.modal-content {
  height: 500px;
  width: 500px;
  background: white;
  border-bottom: 15px solid #46A358;
  display: flex;
  flex-direction: column;
  gap: 40px;
}

.modal-header {
  display: flex;
  flex-direction: column;
}
.buttons {
  display: flex;
  gap: 15px;
  justify-content: center;
  align-items: center;
}
.button-close {
  height: 20px;
  width: 20px;
  align-self: flex-end;
  background: none;
  border: none;
  cursor: pointer;
  color: black;
  font-size: 18px;
  margin-right: 15px;
}
.button-close:hover {
  color: #46A358;
}
.transparent-button {
  display: flex;
  background: none;
  border: none;
  cursor: pointer;
  color: black;
  font-size: 18px;
}
.transparent-button:hover {
  color: #46A358;
}

.input-container {
  width: 320px;
  align-self: center;
  display: flex;
  flex-direction: column;
  gap: 10px;
  align-items: center;
}
input {
  height: 30px;
  width: 300px;
  border-color: #AFAFAF;
  border-radius: 5px;
}
input:focus {
  border-color: #46A358;
  outline: none;
}
.password-container {
  display: flex;
  align-items: center;
}
.toggle {
  background: none;
  border: none;
  cursor: pointer;
  align-items: center;
}
.button-login {
  height: 35px;
  width: 300px;
  background-color: #46A358;
  border: none;
  border-radius: 5px;
  color: white;
  cursor: pointer;
  font-size: 16px;
}

.another-login {
  width: 320px;
  align-self: center;
  display: flex;
  flex-direction: column;
  gap: 10px;
  align-items: center;
}
.social-button {
  height: 35px;
  width: 300px;
  background: none;
  border: 1px solid #AFAFAF;
  border-radius: 5px;
  cursor: pointer;
  display: flex;
  justify-content: center;
  align-items: center;
  gap: 5px;
  color: black;
}
.login {
  display: flex;
  align-items: center;
  justify-content: center;
  width: 100%;
  gap: 5px;
}
.login::before,
.login::after {
  content: "";
  flex-grow: 1;
  height: 1px;
  background-color: #AFAFAF;
}
</style>