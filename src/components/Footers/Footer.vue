<template>
    <div>        
        <div class="row">
            <div class="col-sm-1 m-0 d-flex align-items-center justify-content-center">
                <b-icon-currency-dollar class="icon-size-l text-color-primary text-shadow" />
            </div>
            
            <div class="col-sm-3 m-0">
                <div class="text-center">
                    <span class="">Objetivo</span>

                    <p class="font-footer">Este proyecto, fundado el 19 de junio de 2024, tiene como misión principal ofrecer información detallada sobre todos los tipos de cambio vigentes en Argentina. Además, proporcionamos datos actualizados sobre índices de inflación mensual e interanual, así como otros indicadores económicos relevantes del país.</p>
                </div>
            </div>

            <div 
                class="col-sm-1 m-0 d-flex align-items-center justify-content-center"
                :class="[screenWidth > 768 ? 'vertical-line' : ' top-line']">
                    <b-icon-suit-heart class="icon-size-l text-color-primary margin-top text-shadow" />
            </div>

            <div class="col-sm-3 m-0">
                <div class="text-center">
                    <span>Donaciones</span>

                    <p class="font-footer">
                        ¡Tu apoyo es fundamental para mantener nuestra plataforma actualizada y accesible para todos! Con tu donación podés ayudarnos a seguir proporcionando información ¡Cada contribución cuenta!
                        <button class="btn-primary" v-on:click="goToCafecito()">☕ Invitame un Cafecito</button>
                    </p>
                </div>
            </div>

            <div 
                class="col-sm-1 m-0 d-flex align-items-center justify-content-center"
                :class="[screenWidth > 768 ? 'vertical-line' : 'top-line'] ">
                <b-icon-envelope class="icon-size-l text-color-primary margin-top text-shadow" />
            </div>

            <div class="col-sm-3 m-0">
                <div class="text-center">
                    <span class="">Contacto</span>
                    
                    <p class="font-footer">
                        Por cualquier consulta y sugerencia, están habilitados los siguientes canales de comunicación
                        dolarinformation@gmail.com
                    </p>

                    <p><strong>Redes sociales</strong></p>
                    
                    <a href="https://www.instagram.com/dolarinfo_ar/" target="_blank"><b-icon-instagram class="icon-size-s text-color-primary pointer" /></a>
                    <a href="https://twitter.com/facuespilocin_" target="_blank"><b-icon-twitter class="icon-size-s margin-left text-color-skyblue pointer" /></a>
                </div>
            </div>
        </div>
        <div class="row">
            <div class="col-12 mt-2 font-footer">
                <CopyrightLinks :links="copyrightLinks" />
            </div>
        </div>
    </div>
</template>

<script>
import "@/assets/style.css"
import CopyrightLinks from '@/components/Footers/CopyrightLinks.vue';

export default {
    name: "Footer",
    components: { CopyrightLinks },
    props: { 
        product: Object,
    },

    data() {
        return { 
            screenWidth: window.innerWidth,
            socialLinks: [
                { path: "https://www.instagram.com/dolarinfo_ar/", text: "Instagram" },
                { path: "https://twitter.com/facuespilocin_", text: "Twitter" },
            ],
            copyrightLinks: [
                { path: "/TermsAndConditions", text: "Términos y condiciones" },
                { path: "/PrivacyPolicy", text: "Políticas de privacidad" },
            ],
        }
    },

    async created() {
        this.updateScreenWidth();
        window.addEventListener('resize', this.updateScreenWidth);
    },

    destroyed() {
        window.removeEventListener('resize', this.updateScreenWidth);
    },

    methods: {
        updateScreenWidth() {
            this.screenWidth = window.innerWidth;
        },

        goToCafecito() {
            window.open("https://cafecito.app/facuespilocin", "_blank");
        },
    },

    computed: {
    }
}
</script>