import Vue from 'vue';
import Vuex from 'vuex';
import {user} from "@/store/UserContext";
import {siteInfo} from "@/store/SiteInfoContext";

Vue.use(Vuex);

export default new Vuex.Store({
  modules: {
    user,
    siteInfo
  },
});
