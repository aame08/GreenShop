<script setup>
import { defineProps, ref } from 'vue';
import axios from 'axios';

const props = defineProps({
  isVisible: Boolean,
});

const emit = defineEmits(['close', 'switchToLogin']);

const switchToLogin = () => {
  emit('switchToLogin');
};

const username = ref('');
const email = ref('');
const password = ref('');
const confirmPassword = ref('');
const message = ref('');
const registerUser = async () => {
    if (password.value != confirmPassword.value){
        message.value = 'Пароли не совпадают.';
        return;
    }

    const response = await axios.post('https://localhost:7141/api/Users/register',{
        username: username.value,
        emailUser: email.value,
        passwordUser: password.value,
        confirmPassword: confirmPassword.value
    });
    if (response.status == 201){
        message.value = 'Регистрация прошла успешно.';
    }
    else if (response.status == 409){
        message.value = 'Пользователь с указанной почтой уже зарегистрирован.';
    }
    else {
        message.value = 'Ошибка регистрации.';
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
            <button class="transparent-button" @click="switchToLogin">Login</button>
            <div>|</div>
            <div style="font-size: 18px; color: #46A358;">Register</div>
          </div>
        </div>
        <form @submit.prevent="registerUser" class="input-container">
          <div>Enter your username and password to register.</div>
          <input type="text" placeholder="Username" required v-model="username">
          <input type="email" placeholder="Enter your email address" required v-model="email">
          <div class="password-container">
            <input type="password" placeholder="Password" style="width: 270px;" required v-model="password">
            <button class="toggle">
              <img src="@/assets/login_register/hide_password.png" alt="toggle">
            </button>
          </div>
          <input type="password" placeholder="Confirm Password" style="width: 300px;" required v-model="confirmPassword">
          <button type="submit" class="button-register">Register</button>
        </form>
        <div class="another-login">
          <div class="login"><span>Or register with</span></div>
          <button class="social-button">
            <img src="@/assets/login_register/google_login.png" alt="google">
            <div>Continue with Google</div>
          </button>
          <button class="social-button">
            <img src="@/assets/login_register/facebook_login.png" alt="facebook">
            <div>Continue with Facebook</div>
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
    height: 550px;
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
.button-register {
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